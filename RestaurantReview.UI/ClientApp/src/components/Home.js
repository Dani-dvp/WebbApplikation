import React, { Component } from 'react';
import CarouselClass from './Cards/CarouselClass';
import { Link } from 'react-router-dom';
import '../Css/Home.css';

export default class Home extends Component {
  static displayName = Home.name;


  
  render () {
    return (
      <div className="mx-auto d-block mb-4">
        <CarouselClass></CarouselClass>
        <br />
        <div className="mx-auto">
          <Link data-cy = "homeRestaurantsBtn" tag={Link} className="homeButton btn btn-info btn-lg" to={"/allrestaurants"}>All Restaurants</Link>
          <Link data-cy = "homeCategoriesBtn" tag={Link} className="homeButton btn btn-info btn-lg" to={"/categories"}>Categories</Link>
        </div>
      </div>
    );
  }
}
