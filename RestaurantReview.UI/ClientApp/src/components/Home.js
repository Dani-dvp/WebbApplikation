import React, { Component } from 'react';
import Carousel from './Cards/Carousel';
import '../Css/Home.css';

export default class Home extends Component {
  static displayName = Home.name;


  
  render () {
    return (
      <div>
        <Carousel></Carousel>
       
      </div>
    );
  }
}
