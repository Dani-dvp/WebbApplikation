import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import {AllCategoriesCard} from './Cards/AllCategoriesCard';
import { Link } from 'react-router-dom';
import '../Css/ShowAllRestaurants.css';




export default class ShowRestaurantsByCategory extends Component {
    constructor(props) {
        super(props);
          this.state = {
              restaurants: []
          };
    }

    async componentDidMount() {

  
       
        const response = await axios.get("api/categories");
        this.setState({
            categories: response.data,
      
            
          });

          

}