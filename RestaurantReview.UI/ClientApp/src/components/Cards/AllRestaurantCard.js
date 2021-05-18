import React, { Component } from "react";

export class AllRestaurantCard extends Component {

  render() {
    return (
      <div class="card" style="width: 18rem;">
        <img src="..." class="card-img-top" alt="..." />
          <div class="card-body">
          <p class="card-text">{this.props.header}</p>
          </div>
      </div>
    );
  }
}