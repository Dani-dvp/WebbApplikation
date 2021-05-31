import React, { Component } from 'react'
import ReactDOM from 'react-dom';
import axios from 'axios';
<<<<<<< HEAD:RestaurantReview.UI/ClientApp/src/components/RestaurantPages/ShowAllRestaurants.js
import { AllRestaurantCard } from './AllRestaurantCard';
import './Css/ShowAllRestaurants.css';
=======

import {AllRestaurantCard} from './Cards/AllRestaurantCard';
import { Link } from 'react-router-dom';


import '../Css/ShowAllRestaurants.css';
>>>>>>> 9a4a1a5a0fc81c56b47fc8d65f22c46ed8c193aa:RestaurantReview.UI/ClientApp/src/components/ShowAllRestaurants.js
import { Container, Row, Col } from 'reactstrap';


export default class ShowAllRestaurants extends Component {
  constructor(props) {
    super(props);
    this.state = {
      restaurants: [],
      loading: true
    }
  }


 


  async componentDidMount() {
    const response = await axios.get("api/Restaurants");

    this.setState({
      restaurants: response.data,
      loading: false
    });
    console.log(response.data);
  }

  render() {
    let content = this.state.loading ? <p>Loading...</p> : this.createRestaurnatElements()
    return (
      <div className="Restaurants col-xl-12">{content}</div>
    );

  }

  createRestaurnatElements() {
    let elements = [];
    for (let restaurant of this.state.restaurants) {
      elements.push(<AllRestaurantCard key={restaurant.restaurantName} title={restaurant.restaurantName} restaurantName={restaurant.restaurantName}></AllRestaurantCard>);
    }
    return (elements);
  }
}