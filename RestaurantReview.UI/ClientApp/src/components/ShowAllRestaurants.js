import React, { Component } from 'react'
import ReactDOM from 'react-dom';
import axios from 'axios';
import { AllRestaurantCard } from './Cards/AllRestaurantCard';
import '../Css/ShowAllRestaurants.css';

export default class ShowAllRestaurants extends Component {
  constructor(props) {
    super(props);
    this.state = {
      restaurants: [],
      loading: true
    }
  }


  //getData() {
  //  axios({
  //    method: 'get',
  //    url: "/api/Restaurants",
  //    data: {
  //      Authorization: 'Bearer ' + localStorage.getItem('token')
  //    },

  //  }).then(res => {
  //    var restaurants = []
  //    var data = res.data
  //    for (let i = 0; i < data.length; i++) {
  //      restaurants.push(<AllRestaurantCard key={i} header={data[i]}></AllRestaurantCard>);
  //    }
  //    this.setState({ loading: false });
  //    console.log(res.data)


  //  })
  //};
  //componentDidMount() {
  //  this.getData();
  //}


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
      elements.push(<AllRestaurantCard key={restaurant.restaurantName }title={restaurant.restaurantName}></AllRestaurantCard>);
    }
    return (elements);
  }
}