import React, { Component } from 'react'
import '../Css/Login.css';

export class Login extends Component {
    render() {
        return (
            <div className="wrapper">
                <div id="LoginForm">
        <h2 class="active"> Login </h2>
        <h2 class="inactive underlineHover">Register </h2>



        <form action="/action_page.php" method="post" />
          <input type="text" id="login"  name="login" placeholder="login" />
          <input type="text" id="password" name="password" placeholder="password" />
          <input type="submit"  value="Log In" />


        <form action="/action_page.php" method="post" />
          <input type="button"  value="Sign in with google" />
         

        <div id="ForgotForm">
          <a class="underlineHover" href="#">Forgot Password?</a>
        </div>
            </div>
            </div>
        )
    }
}
