import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import {AllCategoriesCard} from './Cards/AllCategoriesCard';
import { Link } from 'react-router-dom';
import '../Css/ShowAllRestaurants.css';



export default class ShowAllCategories extends Component {
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
          elements.push(<AllCategoriesCard key={category.categoryName} title={category.categoryName} categoryName={category.categoryName}> </AllCategoriesCard>);
       
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
