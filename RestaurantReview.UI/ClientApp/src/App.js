import React, { Component } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Login from './components/Login';
import Categories from './components/Categories';
import CreateReview from './components/CreateReview';
import AddRestaurant from './components/AddRestaurant';
import Register from './components/Register';
import ShowAllRestaurants from './components/ShowAllRestaurants';
import RestaurantPage from './components/RestaurantPage';
import axios from 'axios';
import './custom.css'
import ShowAllCategories from './components/ShowAllCategories';
import ShowRestaurantsInCategory from './components/ShowRestaurantsInCategory';

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
        <Route path='/register' component={Register} />
        <Route path='/allrestaurants' component={ShowAllRestaurants} />
        <Route path='/Restaurantpage/:id' component={RestaurantPage} />
        <Route path='/ShowAllCategories/' component={ShowAllCategories} />
        <Route path='/ShowRestaurantsInCategory/' component={ShowRestaurantsInCategory} />
      </Layout>
    );
  }
}