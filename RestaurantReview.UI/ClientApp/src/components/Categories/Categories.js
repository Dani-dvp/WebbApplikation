import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import {AllCategoriesCard} from './AllCategoriesCard';
import { Link } from 'react-router-dom';
import '../RestaurantPages/Css/ShowAllRestaurants.css';



export default class Categories extends Component {
    constructor(props) {
        super(props);
          this.state = {
              categories: []
          };
    }

    async componentDidMount() {

  
       
        const response = await axios.get("api/categories");
        this.setState({
            categories: response.data,
      
            
          });
        
        console.log(response);
       
   
    }
    CreateCategoriesElements(){
        let elements = [];
        for (let category of this.state.categories) {
          elements.push(<ul key={category.categoryName}><AllCategoriesCard className="ListOfCategories" categoryName={category.categoryName} > {category.categoryName}  </AllCategoriesCard> </ul>);
        }
        return (elements);
    
     }

 
    render() {
        let content =  this.CreateCategoriesElements();
        return (
            <div> {content} </div>      
            );

        
    }

     

 

   
}
