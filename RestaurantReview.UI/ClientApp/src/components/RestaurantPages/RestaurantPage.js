import React, { Component } from "react";
import axios from "axios";
import RestaurantPageCard from "./RestaurantPageCard";
import { ReviewCard } from "../Reviews/ReviewCard";
import "./Css/RestaurantPage.css";

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
        restaurant: response.data,
        reviews: response.data.reviewsDtoResponse
      });
      console.log(response.data);
    }
  

  render() {
    let thisRestaurant = this.createThisRestaurant();
    let ListOfReviews = this.createReviewsList();
    
    return (
      <div className="Trying">
        {thisRestaurant}
        
        { ListOfReviews }
          
      </div>
    );
  }



  createThisRestaurant() {
    let element = <RestaurantPageCard restaurantName={this.state.restaurant.restaurantName} description={this.state.restaurant.description } ></RestaurantPageCard>;
    
    return (element);
  }




  createReviewsList() {
    let elements = [];
    for (let review of this.state.reviews) {
      elements.push(<ReviewCard key={review.reviewID} Rating={review.rating} reviewText={review.reviewText}></ReviewCard>);
    }
    return (elements);
  }
  
}
