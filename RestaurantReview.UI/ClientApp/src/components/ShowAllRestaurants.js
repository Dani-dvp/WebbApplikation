import React, { Component } from 'react'
import ReactDOM from 'react-dom';
import axios from 'axios';
import { AllRestaurantCard } from './Cards/AllRestaurantCard';
import { Link } from 'react-router-dom';
import '../Css/ShowAllRestaurants.css';

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
    <div>{ content }</div>
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