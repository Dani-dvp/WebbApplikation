import React, { Component } from 'react';
import axios from 'axios';
import '../Css/ShowAllRestaurants.css';
import {RestaurantsInCategoryCard} from './Cards/RestaurantsInCategoryCard';
import ReactDOM from 'react-dom';  






export default class ShowRestaurantsInCategory extends Component {
    constructor(props) {
        super(props);
          this.state = {
              restaurants: [],
              category : props.location.state.category,
              categories : '',
             
              loading: true
          };
       console.log(props);
    }
         
    
    componentDidMount() {
        axios.get("api/Restaurants")
          .then(res => {
              
           
            const categories = res.data.map(obj => ({categoryName: obj.categories.categoryName}));
            this.setState({ categories });
          });
          console.log(this.state.categories);
      
      }

  
 CreateRestaurantsInCategoryElements(){
    let elements = [];
    console.log(this.state.category);
  
    for (let restaurant of this.state.restaurants) {
   
    
     if(this.state.category == restaurant.Categories){
        elements.push(<RestaurantsInCategoryCard key={restaurant.categoryName} title={restaurant.restaurantName} restaurantName={restaurant.restaurantName}> </RestaurantsInCategoryCard>);
    }
     }
    return (elements);

 }

 render(){
     var content = this.state.loading ? <p>Loading...</p> :  this.CreateRestaurantsInCategoryElements();
     return (
         <div>
         <div>{content}</div>
         
         </div>
         
     )

 }



}