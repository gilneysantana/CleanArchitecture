import React, {useState} from 'react';
import api from '../services/api';

import './Login.css';
import logo from '../assets/gilney.PNG';


export default function Login({history}) {

    const [username, setUsername] = useState('');

    async function handleSubmit (e) {
        e.preventDefault() //envita o comportamento padrão (nesse caso, submeter o form)

        const response = await api.post('/devs', {username});
        const { _id } = response.data;

        //console.log(response);

        history.push(`/dev/${_id}`);
    }

    return (
        <div className="login-container">
            <form onSubmit={handleSubmit}>
            <img src={logo} alt="nao achei a figura." />
            <input
                placeholder= "Digite seu Github"
                value = {username}
                onChange = { e =>  setUsername(e.target.value) }
            />
            <button type="submit">Enviar</button>
            </form>
        </div>
    );
}