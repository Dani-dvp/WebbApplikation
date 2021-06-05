import React, { Component } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Login from './components/Authentication/Login';
import CreateReview from './components/Reviews/CreateReview';
import AddRestaurant from './components/RestaurantPages/AddRestaurant';
import Register from './components/Authentication/Register';
import ShowAllRestaurants from './components/RestaurantPages/ShowAllRestaurants';
import RestaurantPage from './components/RestaurantPages/RestaurantPage';
import './custom.css'
import ProfilePage from './components/Profile/ProfilePage';
import Categories from './components/Categories/Categories';
import CategoryPage from './components/Categories/CategoryPage';
import NavMenu from './components/NavMenu';
import AddCategory from './components/Categories/AddCategory';


export default class App extends Component {
  static displayName = App.name;
  constructor() {
    super();
this.state = {
  loggedIn: null,
  user: null
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
          path='/createreview/:id'
          render={props => (
            <CreateReview {...props} user={this.state.user} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/addrestaurant'
          render={props => (
            <AddRestaurant {...props} user={this.state.user} loggedIn={this.state.loggedIn} />
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
          path='/Profile/'
          render={props => (
            <ProfilePage {...props} user={this.state.user} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/Categories/'
          render={props => (
            <Categories {...props} loggedIn={this.state.loggedIn} />
          )}
           />
        <Route
          path='/Categorypage/name/:id'
          render={props => (
            <CategoryPage {...props} loggedIn={this.state.loggedIn} />
          )}
          />
        <Route
          path='/AddCategory'
          render={props => (
          <AddCategory {...props} loggedIn={this.state.loggedIn} />
        )}
        />
        
      </Layout>
    );
  }
}