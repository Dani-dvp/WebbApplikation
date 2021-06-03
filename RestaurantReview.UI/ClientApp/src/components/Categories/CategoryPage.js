import React, { Component } from 'react';
import axios from 'axios';
import { AllCategoriesCard } from './AllCategoriesCard';
import '../RestaurantPages/Css/ShowAllRestaurants.css';
import { AllRestaurantCard } from '../RestaurantPages/AllRestaurantCard';






export default class CategoryPage extends Component {
    constructor(props) {
        super(props);
          this.state = {
              restaurants: [],
            category: '',
            categoryName: this.props.match.params.id
             
          };
       
    }
         
    
    async componentDidMount() {
      const response = await axios.get("api/categories/name/" + this.props.match.params.id)

      this.setState({
        category: response.data,
        restaurants: response.data.restaurantResponses
      });
      console.log(response.data.restaurantResponses);
      console.log(response.data);
      
      }

  
 CreateRestaurantsInCategoryElements(){
    let elements = [];;
  
    for (let restaurant of this.state.restaurants) {
       elements.push(<AllRestaurantCard key={restaurant.restaurantName} title={restaurant.restaurantName} restaurantName={restaurant.restaurantName}> </AllRestaurantCard>);
    }
     
    return (elements);

 }

 render(){
     var content =  this.CreateRestaurantsInCategoryElements();
     return (
         <div>
         <div>{content}</div>
         
         </div>
         
     )

 }



}