import { PayloadAction, createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { Environment } from "./data";
import { api } from '../../utils/api';
import { parametersToObject, objectToParameters } from '../../utils/mapper';
import { Parameters } from '../ParameterList/data';

const defaultEnvironment: Environment = {
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

export const getEnvironment = createAsyncThunk('environment/getEnvironment', async () =>
    await api.get(`/environment`));

export const updateEnvironment = createAsyncThunk('environment/updateEnvironment', async (parameters: Parameters) =>
    await api.put(`/environment`, parametersToObject(parameters)));

const setEnvironment = (state: Environment, payload: any) => {
    state.loading = false;
    state.error = undefined;
    state.parameters = objectToParameters(payload);
};

const environmentSlice = createSlice({
    name: 'environment',
    initialState,
    reducers: {
        changeEnvironment(state, action: PayloadAction<any>) {
            setEnvironment(state, action.payload);
        },
        setError(state, action: PayloadAction<string>) {
            state.error = action.payload;
        }
    },
    extraReducers: (builder) => {
        builder.addCase(getEnvironment.pending, (state) => {
            state.loading = true;
        });
        builder.addCase(getEnvironment.fulfilled, (state, action: PayloadAction<any>) =>
            setEnvironment(state, action.payload));
        builder.addCase(getEnvironment.rejected, (state, action) => {
            state.error = action.error.message;
        });
        builder.addCase(updateEnvironment.pending, (state) => {
            state.loading = true;
        });
        builder.addCase(updateEnvironment.fulfilled, (state, action: PayloadAction<any>) =>
            setEnvironment(state, action.payload));
        builder.addCase(updateEnvironment.rejected, (state, action) => {
            state.loading = false;
            state.error = action.error.message;
        });
    }
});

export const {
    changeEnvironment,
    setError
} = environmentSlice.actions;

export default environmentSlice.reducer;
