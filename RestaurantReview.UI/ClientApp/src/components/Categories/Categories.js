import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import {AllCategoriesCard} from './AllCategoriesCard';
import { Link } from 'react-router-dom';
import '../RestaurantPages/Css/ShowAllRestaurants.css';
import "./Css/Categories.css";



export default class Categories extends Component {
    constructor(props) {
        super(props);
          this.state = {
              categories: []
          };
    }

    async componentDidMount() {

  
       
      const response = await axios.get("api/v1/categories");
        this.setState({
            categories: response.data,
      
            
          });
        
        console.log(response);
       
   
    }
    CreateCategoriesElements(){
        let elements = [];
        for (let category of this.state.categories) {
          elements.push(<ul className="ListOfCategories" key={category.categoryName}><AllCategoriesCard className="ListOfCategories" categoryName={category.categoryName} > {category.categoryName}  </AllCategoriesCard> </ul>);
        }
        return (elements);
    
     }

 
    render() {
        let content =  this.CreateCategoriesElements();
      return (

        <div
          className="mx-auto d-block"> <br /> {content}
          <h5 style={{ color: "#f9e7d9" }}>Cant find your Category?</h5>
          <Link data-cy="addCategoryButton"className="homeButton mx-auto btn btn-danger " style={{ background: "#a73003", color: "#f9e7d9" }} to="/AddCategory">Add a Category</Link>
        </div>      
            );

        
    }

     

 

   
}
