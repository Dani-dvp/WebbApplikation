import React, { Component } from 'react'
import axios from 'axios';
import {AllRestaurantCard} from './AllRestaurantCard';
import './Css/ShowAllRestaurants.css';
import { Link } from 'react-router-dom';


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
      <div>
        <div className="Restaurants col-xl-12">{content}</div>
        <h3>Cant find what you are looking for?</h3>
        <div>
          <form >
            <Link
              data-cy="addRestaurant"
              className=" btn btn-info btn-lg"
              to="/addrestaurant">Add A Restaurant!</Link>
          </form>
        </div>
        </div>
    );

  }

  createRestaurnatElements() {
    let elements = [];
    for (let restaurant of this.state.restaurants) {
      elements.push(<AllRestaurantCard TempImage={restaurant.tempImage} key={restaurant.restaurantName} title={restaurant.restaurantName} restaurantName={restaurant.restaurantName}></AllRestaurantCard>);
    }
    return (elements);
  }
}