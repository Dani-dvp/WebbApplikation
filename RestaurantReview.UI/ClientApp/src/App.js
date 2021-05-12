import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Login } from './components/Login';
import { Categories } from './components/Categories';
import { CreateReview } from './components/CreateReview';
import { AddRestaurant } from './components/AddRestaurant';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/login' component={Login} />
        <Route path='/categories' component={Categories} />
        <Route path='/createreview' component={CreateReview} />
        <Route path='/addrestaurant' component={AddRestaurant} />
      </Layout>
    );
  }
}