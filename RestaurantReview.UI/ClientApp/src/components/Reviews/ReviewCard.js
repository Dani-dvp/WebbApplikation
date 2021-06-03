import React, { Component } from 'react';
import './Css/ReviewCard.css';

export class ReviewCard extends Component {

  render() {
    return (
      <div className="card reviewCard" >
          <div className="lead">
            <h2> {this.props.reviewText} </h2>
            <footer className="display-4"> {this.props.Rating} / 5</footer>
          </div>
      </div>
      );
  }

}