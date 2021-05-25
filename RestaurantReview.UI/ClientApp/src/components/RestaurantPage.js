import React, { Component } from "react";
import axios from "axios";
import RestaurantPageCard from "./Cards/RestaurantPageCard";
import { ReviewCard } from "./Cards/ReviewCard";
import "../Css/RestaurantPage.css";

export default class RestaurantPage extends Component {
  constructor(props) {
    super(props);
    this.state = {
      restaurant: {},
      reviews: []
    };
  }

  
    
    async componentDidMount() {
      const response = await axios.get("api/Restaurants/name/" + this.props.match.params.id);

      this.setState({
        restaurants: response.data,
        reviews: response.data.reviewsDtoResponse
      });
      console.log(response.data);
    }
  

  render() {
    let content = this.createThisRestaurant();
    let content2 = this.createReviewsList();
    return (
      <div className="Trying">
        {content}
        <div>
          { content2 }
          </div>
      </div>
    );
  }



  createThisRestaurant() {
    let element = <RestaurantPageCard restaurantName={this.state.restaurant.restaurantName} description={ this.state.restaurant.description } ></RestaurantPageCard>;

    return element;
  }




  createReviewsList() {
    let elements = [];
    for (let review of this.state.reviews) {
      elements.push(<ReviewCard key={review.reviewID} Rating={review.rating} reviewText={review.reviewText}></ReviewCard>);
    }
    return (elements);
  }
}
