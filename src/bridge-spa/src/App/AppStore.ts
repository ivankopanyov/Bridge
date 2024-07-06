import { createAsyncThunk, createSlice, PayloadAction } from '@reduxjs/toolkit';
import { api } from '../utils/api';

interface Auth {
    username: string;
    password: string;
}

const defaultApp: {
    auth?: 'authorized' | 'unauthorized';
    page?: 'signin' | 'signup';
    loading: boolean;
    error?: string;
} = {
    loading: true
};

const initialState = defaultApp;

export const auth = createAsyncThunk('auth', async () => await api.get('/auth'));

export const refresh = createAsyncThunk('auth/refresh', async () => await api.refresh());

export const signIn = createAsyncThunk('auth/signIn', async (auth: Auth) => await api.post('/auth/signIn', auth));

export const signUp = createAsyncThunk('auth/signUp', async (auth: Auth) => await api.post('/auth/signUp', auth));

export const signOut = createAsyncThunk('auth/signOut', async () => await api.delete('/auth/signOut'));

const appSlice = createSlice({
    name: 'app',
    initialState,
    reducers: {
        unauthorized(state) {
            state.auth = 'unauthorized';
        },
        setError(state, action: PayloadAction<string | undefined>) {
            state.error = action.payload;
        }
    },
    extraReducers: (builder) => {
        builder.addCase(auth.pending, state => {
            state.loading = true;
        });
        builder.addCase(auth.fulfilled, state => {
            state.error = undefined;
            state.page = 'signin';
            state.loading = false;
        });
        builder.addCase(auth.rejected, (state, action) => {
            if (action.error.code === '404') {
                state.error = undefined;
                state.page = 'signup';
            } else {
                state.error = action.error.message;
            }
            state.loading = false;
        });

        builder.addCase(refresh.pending, state => {
            state.loading = true;
        });
        builder.addCase(refresh.fulfilled, state => {
            state.error = undefined;
            state.auth = 'authorized';
            state.page = 'signin';
            state.loading = false;
        });
        builder.addCase(refresh.rejected, (state, action) => {
            if (action.error.code === '401') {
                state.error = undefined;
                state.auth = 'unauthorized';
            } else {
                state.error = action.error.message;
                state.loading = false;
            }
        });

        builder.addCase(signIn.pending, state => {
            state.loading = true;
            state.error = undefined;
        });
        builder.addCase(signIn.fulfilled, state => {
            state.loading = false;
            state.error = undefined;
            state.auth = 'authorized';
        });
        builder.addCase(signIn.rejected, (state, action) => {
            if (action.error.code === '403') {
                state.error = 'The user has not yet been registered.';
                state.page = 'signup';
            } else {
                state.error = action.error.message;
            }
            state.loading = false;
        });

        builder.addCase(signUp.pending, state => {
            state.loading = true;
            state.error = undefined;
        });
        builder.addCase(signUp.fulfilled, state => {
            state.loading = false;
            state.error = undefined;
            state.auth = 'authorized';
            state.page = 'signin';
        });
        builder.addCase(signUp.rejected, (state, action) => {
            if (action.error.code === '403') {
                state.error = 'The user has already been registered.';
                state.page = 'signin';
            } else {
                state.error = action.error.message;
            }
            state.loading = false;
        });

        builder.addCase(signOut.pending, state => {
            state.loading = true;
            state.error = undefined;
        });
        builder.addCase(signOut.fulfilled, state => {
            state.auth = 'unauthorized';
            state.error = undefined;
            state.loading = false;
        });
        builder.addCase(signOut.rejected, (state, action) => {
            if (action.error.code === '401') {
                state.auth = 'unauthorized';
                state.error = undefined;
            } else {
                state.error = action.error.message;
            }
            state.loading = false;
        });
    }
});

export const {
    unauthorized,
    setError
} = appSlice.actions;

export default appSlice.reducer;
