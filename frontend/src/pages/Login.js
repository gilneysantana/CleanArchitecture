import React, { useState } from 'react';
//import api from '../services/api';
import api from '../services/api';

import './Login.css';
import logo from '../assets/generic.png';
import { Link } from 'react-router-dom';


export default function Login({ history }) {

    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');

    async function handleSubmit(e) {
        e.preventDefault() //evita o comportamento padrão (nesse caso, submeter o form)

        //const response = await api.post('/devs', {username, password});
        const response = await api.post('/Login', { username, password, "_id": "bosta" });
        const { _id } = response.data;

        //console.log(response);

        history.push(`/dev/${_id}`);
    }

    return (
        <div className="login-container">
            <form onSubmit={handleSubmit}>
                <img src={logo} alt="nao achei a figura." />
                <input placeholder="Digite seu Github" value={username} onChange={e => setUsername(e.target.value)} />
                <input placeholder="Password" value={password} onChange={e => setPassword(e.target.value)} />
                <button type="submit">Sign in</button>
                <Link to="/newAccount" >Register</Link>
            </form>

        </div>
    );
}