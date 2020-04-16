import axios from 'axios';

/*
const api = axios.create({
    baseURL: 'http://localhost:3333'
});
*/

const api = axios.create({
    baseURL: 'http://localhost:57678/api'
});

export default api;