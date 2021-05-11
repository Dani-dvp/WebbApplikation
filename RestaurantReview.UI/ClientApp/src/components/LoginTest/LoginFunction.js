import React, { Component, useState } from 'react'
import PropTypes from 'prop-types';
import { Login } from './Login.js';



export default function LoginFunction({ setToken }) {


  const handleSubmit = async e => {
    e.preventDefault();
    const token = await loginUser({
      username,
      password
    });
    setToken(token);
  }

  async function loginUser(credentials) {
    return await fetch('http://localhost:8080/login', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(credentials)
    })
      .then(data => data.json())
  }

  Login.propTypes = {
    setToken: PropTypes.func.isRequired
  };