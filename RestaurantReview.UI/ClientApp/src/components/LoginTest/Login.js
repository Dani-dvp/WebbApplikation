import React, { Component, useState } from 'react'
import '../Login.css';
import { LoginFunction } from './LoginFunction.js';

const [username, setUserName] = useState();
const [password, setPassword] = useState();


export class Login extends Component {
  render() {
        return (
            <div className="wrapper">
                <div id="LoginForm">
        <h2 class="active"> Login </h2>
        <h2 class="inactive underlineHover">Register </h2>



              <form action="/action_page.php" method="post" onSubmit={ handleSubmit }>
              <input type="text" id="login" name="login" onChange={e => setUserName(e.target.value)} placeholder="login" />
              <input type="text" id="password" name="password" onChange={e => setPassword(e.target.value)} placeholder="password" />
                <input type="submit" value="Log In" />
        </form>


        <form action="/action_page.php" method="post" />
          <input type="button"  value="Sign in with google" />
         

        <div id="ForgotForm">
          <a class="underlineHover" href="#">Forgot Password?</a>
        </div>
            </div>
            </div>
          )
      }
  const handleSubmit = async e => {
    e.preventDefault();
    const token = await loginUser({
      username,
      password
    });
    setToken(token);
  }
  


}
