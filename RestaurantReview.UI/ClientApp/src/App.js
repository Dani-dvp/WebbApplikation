import React, { Component } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Login from './components/Login';
import Categories from './components/Categories';
import CreateReview from './components/CreateReview';
import AddRestaurant from './components/AddRestaurant';
import Register from './components/Register';
import axios from 'axios';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  componentDidMount = () => {
    axios.get('/api/authentication/user').then(
      res => {
        console.log(res);
        this.setState({
          user: res.data
        });
      },
      err => {
        console.log(err)
      });
  }

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/login' component={Login} />
        <Route path='/categories' component={Categories} />
        <Route path='/createreview' component={CreateReview} />
        <Route path='/addrestaurant' component={AddRestaurant} />
        <Route path='/register' component={Register} />
      </Layout>
    );
  }
}