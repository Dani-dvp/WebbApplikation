import React, { Component } from "react";

export class AllRestaurantCard extends Component {

  render() {
    return (
      
      <div className="card" rows="4">
        <img src="..." className="card-img-top" alt="..." />
          <div className="card-body">
          <p className="card-text">{this.props.title}</p>
          </div>
        </div>
        
    );
  }
}