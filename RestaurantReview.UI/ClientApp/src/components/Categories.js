import React, { Component } from 'react';
import '../Css/Categories.css';
import axios from 'axios';
import ReactDOM from 'react-dom';
import ShowRestaurantsInCategory from './ShowRestaurantsInCategory';
import { Redirect } from 'react-router-dom';






export default class Categories extends Component {
    constructor(props) {
        super(props);
          this.state = {
            category : "",
            shouldRedirect : false
              
          };
    }

 

    tesFunc(event) {
        this.setState ({
           category : event.target.innerText,
           shouldRedirect : true

        });
        console.log(this.state);
         
       
    
        
    }
    


    
    render(event) {
        if (this.state.shouldRedirect) {
            return  <Redirect to={{
            pathname: "/ShowRestaurantsInCategory",
            state: { category: this.state.category }
  }}
/>
           }
           else{
               
        

         return (
           
            <div>
          
             
                <h1 id="cat">Categories</h1>


                <div id="Category"  >

                    <ul>
                        <li id="tagC">Cuisine</li>
                        <br />


                        <li className="Cuisine" onClick={this.tesFunc.bind(this)} > African  </li>



                        <li className="Cuisine" onClick={this.tesFunc.bind(this)}>American</li>
                        <li className="Cuisine" onClick={this.tesFunc.bind(this)}>British</li>
                        <li className="Cuisine" onClick={this.tesFunc.bind(this)}>Chinese</li>
                        <li className="Cuisine" onClick={this.tesFunc.bind(this)}>Italian</li>
                        <li className="Cuisine" onClick={this.tesFunc.bind(this)}>Thai</li>
                        <li className="Cuisine" onClick={this.tesFunc.bind(this)}>Indian</li>
                    </ul>
                    <ul>
                        <li id="tagV">Variants</li>
                        <br />
                        <li className="Variants" onClick={this.tesFunc.bind(this)}>Burger</li>
                        <li className="Variants" onClick={this.tesFunc.bind(this)}>Pizza</li>
                        <li className="Variants" onClick={this.tesFunc.bind(this)}>Fish</li>
                        <li className="Variants" onClick={this.tesFunc.bind(this)}>Vegetarian</li>
                        <li className="Variants" onClick={this.tesFunc.bind(this)}>Sushi</li>
                        <li className="Variants" onClick={this.tesFunc.bind(this)}>Pasta</li>
                        <li className="Variants" onClick={this.tesFunc.bind(this)}>Sallad</li>
                    </ul>

                </div>

                <form>
                    <button className="allButton" type="button"><a href="../allrestaurants">View all restaurants</a></button>
                    <button className="allButton" type="button"><a href="../ShowAllCategories/">Show All categories</a></button>





                </form>
            </div>
        );


    }


}
 
}
