import React, { Component } from 'react';
import { Link } from 'react-router-dom';

export class ReviewCard extends Component {

  render() {
    return (
      <div className="card reviewCard" >
          <div className="lead">
          <h2> {this.props.reviewText} </h2>
          <Link tag={Link} className="display-4" link to={"/RestaurantPage/" + this.props.restaurantName}> {this.props.restaurantName}</Link>
          <footer className="display-4"> - {this.props.Rating} / 5</footer>
          </div>
      </div>
      );
  }

}