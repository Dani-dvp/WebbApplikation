import React, { Component } from 'react';
import axios from 'axios';
import { AllRestaurantCard } from './Cards/AllRestaurantCard';
import '../Css/RestaurantPage.css';



export default class RestaurantPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
     
      restaurant: {},
      loading: true
      
    }
  }

  
  
  


  async componentDidMount() {
    console.log(this.props.match.params.id);
    const response = await axios({
      method: 'get',
      url: "/api/Restaurants/name/" + this.props.match.params.id,
      data: {
        Authorization: 'Bearer ' + localStorage.getItem('token'),
        RestaurantName: this.props.match.params.id
      },

    });
  }

  render() {
    
    let content = this.state.loading ? <p>Loading...</p> : this.createThisRestaurant()
    return (
      <div>{content}</div>
    );

  }
  createThisRestaurant() {
    let element = <AllRestaurantCard ></AllRestaurantCard>;

    return (element);


  }
}

