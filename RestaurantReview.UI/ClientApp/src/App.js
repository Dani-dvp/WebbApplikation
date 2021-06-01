import React, { Component } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Login from './components/Authentication/Login';
import Categories from './components/Categories/Categories';
import CreateReview from './components/Reviews/CreateReview';
import AddRestaurant from './components/RestaurantPages/AddRestaurant';
import Register from './components/Authentication/Register';
import ShowAllRestaurants from './components/RestaurantPages/ShowAllRestaurants';
import RestaurantPage from './components/RestaurantPages/RestaurantPage';
import axios from 'axios';
import './custom.css'
import ProfilePage from './components/Profile/ProfilePage';
import ShowAllCategories from './components/Categories/ShowAllCategories';
import ShowRestaurantsInCategory from './components/Categories/ShowRestaurantsInCategory';
import FileUpload from './components/FileUpload/FileUpload';

export default class App extends Component {
  static displayName = App.name;
  constructor() {
    super();
this.state = {
  loggedIn: "This is some loggedinstuff",
  user: {}
    }
    this.handleLogin = this.handleLogin.bind(this);
    this.handleFailedLogin = this.handleFailedLogin.bind(this);
  }

  handleLogin(data) {
    this.setState({
      loggedIn: true,
      user: data
    })
  };
  handleFailedLogin() {
    this.setState({
      loggedIn: false,
      user: null
    })
  };

  

  render() {
    return (
      <Layout>
        <Route
          exact
          path={'/'}
          render={props => (
            <Home {...props} loggedIn={this.state.loggedIn} />
            )}
           />
        <Route
          path='/login'
          render={props => (
            <Login {...props} handleLogin={this.handleLogin} handleFailedLogin={this.handleFailedLogin} loggedIn={this.state.loggedIn} />
          )}
          />
        <Route
          path='/categories'
          render={props => (
            <Categories {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/createreview'
          render={props => (
            <CreateReview {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/addrestaurant'
          render={props => (
            <AddRestaurant {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/register'
          render={props => (
            <Register {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/restaurants'
          render={props => (
            <ShowAllRestaurants {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/Restaurantpage/:id'
          render={props => (
            <RestaurantPage {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/Profile'
          render={props => (
            <ProfilePage {...props} user={this.state.user} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/ShowAllCategories/'
          render={props => (
            <ShowAllCategories {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/ShowRestaurantsInCategory/'
          render={props => (
            <ShowRestaurantsInCategory {...props} loggedIn={this.state.loggedIn} />
          )}
        />
        {/*<Route*/}
        {/*  render={props => (*/}
        {/*    <FileUpload {...props} user={this.state.user} loggedIn={this.state.loggedIn} />*/}
        {/*  )}*/}
        {/*/>*/}
      </Layout>
    );
  }
}