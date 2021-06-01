import React, { Component } from 'react';

export class ReviewCard extends Component {

  render() {
    return (
      <div className="card">
          <blockquote className="blockquote mb-0">
            <h2> {this.props.reviewText} </h2>
            <footer className="blockquote-footer"> {this.props.Rating} / 5</footer>
          </blockquote>
      </div>
      );
  }

}