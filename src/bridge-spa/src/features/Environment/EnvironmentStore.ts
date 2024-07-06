import { PayloadAction, createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { Environment } from "./data";
import { Parameters } from '../ParameterList/data';
import { api } from '../../utils/api';
import { object, params } from '../../utils/mapper';

const defaultEnvironment: Environment = {
    auth: true,
    loading: false,
    parameters: {
        booleanParameters: [],
        stringParameters: [],
        listParameters: [],
        booleanMapParameters: [],
        stringMapParameters: []
    }
};

const initialState: Environment = defaultEnvironment;

export const updateEnvironment = createAsyncThunk('environment/updateEnvironment', async (parameters: Parameters) =>
    await api.put(`/environment`, object(parameters)));

const setEnvironment = (state: Environment, payload: object) => {
    state.loading = false;
    state.error = undefined;
    state.parameters = params(payload);
};

const environmentSlice = createSlice({
    name: 'environment',
    initialState,
    reducers: {
        changeEnvironment(state, action: PayloadAction<any>) {
            setEnvironment(state, action.payload);
        },
        setLoading(state, action: PayloadAction<boolean>) {
            state.loading = action.payload;
        },
        setError(state, action: PayloadAction<string | undefined>) {
            state.error = action.payload;
        },
        authorized(state) {
            state.auth = true;
        }
    },
    extraReducers: (builder) => {
        builder.addCase(updateEnvironment.pending, (state) => {
            state.loading = true;
        });
        builder.addCase(updateEnvironment.fulfilled, (state, action: PayloadAction<any>) => {
            setEnvironment(state, action.payload);
        });
        builder.addCase(updateEnvironment.rejected, (state, action) => {
            state.loading = false;
            if (action.error.code === '401') {
                state.error = undefined;
                state.auth = false;
            } else {
                state.error = action.error.message;
            }
        });
    }
});

export const {
    changeEnvironment,
    setLoading,
    setError,
    authorized
} = environmentSlice.actions;

export default environmentSlice.reducer;
