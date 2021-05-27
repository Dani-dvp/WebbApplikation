import React, { Component } from 'react';
import CarouselClass from './Cards/CarouselClass';
import '../Css/Home.css';

export default class Home extends Component {
  static displayName = Home.name;


  
  render () {
    return (
      <div className="mx-auto d-block">
        <CarouselClass></CarouselClass>

        <div className="mx-auto">
          <button>All Restaurants</button>
          <br />
          <button>Categories</button>
        </div>
      </div>
    );
  }
}
