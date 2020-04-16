import React, { useState } from 'react';
//import api from '../services/api';
import api from '../services/api';

import './Login.css';
import logo from '../assets/generic.png';
import { Link } from 'react-router-dom';


export default function NewAccount({ history }) {

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

    //https://dev.to/detoner777/show-hide-password-on-toggle-in-react-hooks-1lph
    return (
        <div className="login-container">
            <form onSubmit={handleSubmit}>
                <img src={logo} alt="nao achei a figura." />
                <input placeholder="Name" value={username} onChange={e => setUsername(e.target.value)} />
                <input placeholder="Email" />
                <input placeholder="Password" value={password} onChange={e => setPassword(e.target.value)} />
                <input placeholder="Confirm password" />
                <button type="submit">Register</button>
                <Link to="/"><button>Back</button></Link>
            </form>
        </div>
    );
}