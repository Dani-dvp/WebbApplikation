import React, { Component } from "react";
import axios from "axios";
import RestaurantPageCard from "./Cards/RestaurantPageCard";
import "../Css/RestaurantPage.css";

export default class RestaurantPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      restaurant: {},
    };
  }

  async componentDidMount() {
    console.log(this.props.match.params.id);
    const response = await axios({
      method: "get",
      url: "/api/Restaurants/name/" + this.props.match.params.id,
      
    });

  }

  render() {
    let content = this.createThisRestaurant();
    
    return <div>{content}</div>;
  }
  createThisRestaurant() {
    let element = <RestaurantPageCard></RestaurantPageCard>;

    return element;
  }
}
