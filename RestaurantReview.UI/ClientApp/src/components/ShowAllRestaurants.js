import React, { Component } from 'react'
import axios from 'axios';
import { AllRestaurantCard } from './Cards/AllRestaurantCard';
import '../Css/ShowAllRestaurants.css';

export default class ShowAllRestaurants extends Component {
  state = {
    loading: true,
    restaurants: []
  };

  getData() {
    axios({
      method: 'get',
      url: "/api/Restaurants",
      data: {
        Authorization: 'Bearer ' + localStorage.getItem('token')
      },

    }).then(res => {
      var data = res.data
      var forEachData = ''
      data.forEach(d => forEachData += `<AllRestaurantCard>${d.restaurantName}</AllRestaurantCard>`)
      this.setState({ loading: false });
      console.log(res.data)

      this.setState({ restaurants: forEachData })
    })
  };
  componentDidMount() {
    this.getData();
  }

  render() {
    

    if (this.state.loading) {
      return <div>loading...</div>;
    }

    if (!this.state.restaurants.length) {
      return <div>
        <div><h1>didn't get a restaurant</h1></div>
      </div>;
    }

   
    const { restaurants } = this.state
    return (
      <div>
        <div>
          <ul className="TooHigh" dangerouslySetInnerHTML={{ __html: restaurants }}></ul>
        </div>
      </div>
    );
  }
}