import React, { Component } from 'react';
import '../Css/Categories.css';
import axios from 'axios';




export default class Categories extends Component {
    constructor(props) {
        super(props);
          this.state = {
              Categories: []
              
          };
    }


tesFunc() {
    console.log("test");
}

 
    render() {
 
        return (
            <div>
        
                <h1 id="cat">Categories</h1>
               

            <div id="Category" onClick={this.tesFunc}>
          
                <ul>
                    <li id="tagC">Cuisine</li>
                    <br />
                    <li className="Cuisine" id="test">African</li>
                    <li className="Cuisine">American</li>
                    <li className="Cuisine">British</li>
                    <li className="Cuisine">Chinese</li>
                    <li className="Cuisine">Italian</li>
                    <li className="Cuisine">Thai</li>
                    <li className="Cuisine">Indian</li>
                </ul>
                <ul>
                    <li id="tagV">Variants</li>
                    <br />
                    <li className="Variants">Burger</li>
                    <li className="Variants">Pizza</li>
                    <li className="Variants">Fish</li>
                    <li className="Variants">Vegetarian</li>
                    <li className="Variants">Sushi</li>
                    <li className="Variants">Pasta</li>
                    <li className="Variants">Sallad</li>
                </ul>
            
            </div>
           
            <form>
                <button className="allButton"type="button"><a href="../allrestaurants">View all restaurants</a></button>
                <button className="allButton"type="button"><a href="../ShowAllCategories/">Show All categories</a></button>

             
            
            </form>
            </div>      
            );

        
    }
 
 
}
