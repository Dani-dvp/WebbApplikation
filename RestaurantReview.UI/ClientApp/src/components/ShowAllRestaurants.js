import React, { Component } from 'react'
import axios from 'axios';

export default class ShowAllRestaurants extends React.Component {
  state = {
    loading: true,
    restaurants: []
  };

  async componentDidMount() {
    axios({
      method: 'get',
      url: "/api/Restaurants",
      data: {
        Authorization: 'Bearer ' + localStorage.getItem('token')
      },

    }).then(res => {
      this.setState({ restaurants: res.data, loading: false });
      console.log(res.data)
    })
  };


  render() {
    if (this.state.loading) {
      return <div>loading...</div>;
    }

    if (!this.state.restaurants.length) {
      return <div>didn't get a restaurant</div>;
    }

   

    return (
      <div>
        {this.state.restaurants.map(restaurant => (
          <div key={restaurant.RestaurantName}>
            <div>{restaurant.Category}</div>
          </div>
        ))}
      </div>
    );
  }
}