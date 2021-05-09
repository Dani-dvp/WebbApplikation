import React, { Component } from 'react';
import '../Css/Categories.css';

export class Categories extends Component {
    render() {
        return (
            <div>
                
                <p id="cat">Categories</p>
               

            <div id="Category">
                <ul>
                    <li id="tagC">Cuisine</li>
                    <br />
                    <li class="Cuisine">African</li>
                    <li class="Cuisine">American</li>
                    <li class="Cuisine">British</li>
                    <li class="Cuisine">Chinese</li>
                    <li class="Cuisine">Italian</li>
                    <li class="Cuisine">Thai</li>
                    <li class="Cuisine">Indian</li>
                </ul>
                <ul>
                    <li id="tagV">Variants</li>
                    <br />
                    <li class="Variants">Burger</li>
                    <li class="Variants">Pizza</li>
                    <li class="Variants">Fish</li>
                    <li class="Variants">Vegetarian</li>
                    <li class="Variants">Sushi</li>
                    <li class="Variants">Pasta</li>
                    <li class="Variants">Sallad</li>
                </ul>
            
            </div>
            <form>
                <button class="allButton"type="button"><a href="../categories/categories.html">View all restaurants</a></button>
            </form>
            </div>      
            );
    }
}
