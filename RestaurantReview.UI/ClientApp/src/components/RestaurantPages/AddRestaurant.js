import React, { Component } from 'react'
import './Css/StarRating.css';
import './Css/AddRestaurant.css';
import Axios from 'axios';

export default class AddRestaurant extends Component {
  constructor(props) {
    super(props);
    this.state = {
      categories: [],
      loading: true,
      selectedCategory: ""
    };
    this.CreateDropdownMenu = this.CreateDropdownMenu.bind(this);
    this.onChange = this.onChange.bind(this);
  }

  componentDidMount() {
    Axios.get('api/categories')
      .then(res => {
        this.setState({
          categories: res.data,
          loading: false
        })

      })
  }

  CreateDropdownMenu() {
    let elements = [];
    for (let category of this.state.categories) {
      elements.push(<option key={category.categoryName} value={category.categoryName}>{category.categoryName}</option>)
    }
    return (elements);
  }
  onChange(selectedCategory) {
    console.log(selectedCategory)
    this.setState({ selectedCategory: selectedCategory });
  }

  render() {

    let DropdownOptions = this.state.loading ? <p>Loading...</p> : this.CreateDropdownMenu()
        return (
            <div>
            <div>
                <br />
                <h1 className="Header">Add a restaurant</h1>
            </div>
            <div>
                <form id="addForm">
                    <input 
                    data-cy="restaurantName"
                  id="restaurantName" 
                    type="text"
                    placeholder=" Restaurant name:" />
                <br />
                <input
                  data-cy="imageUrl"
                  id="imageUrl"
                  type="text"
                  placeholder="ImageUrl:" />
                <br />
                <input
                  data-cy="restaurantlink"
                  id="restaurantlink"
                  type="text"
                  name="restaurant"
                  placeholder=":Restaurant Websitelink" />
                <br />
                   <div>
                  <select 
                    id="firstAdd" 
                    type="text" 
                    name="Category"
                    value={this.state.selectedCategory}
                    onChange={this.onChange}
                  >
                    
                        <option value="option">Category</option>
                         {DropdownOptions}
                  </select>
                  </div>
                    
                    
                <button 
                  data-cy="submitRestaurant"
                  className="submit"
                  onClick={console.log(this.state.selectedCategory)}>Submit</button>
                </form>
            </div>
            </div>
        )
  }

  addRestaurantRequest = event => {

    event.preventDefault();

    let restaurantName = document.getElementById("restaurantName").value;
    let imageUrl = document.getElementById("imageUrl").value;
    let restaurantlink = document.getElementById("restaurantlink").value;
    Axios({
      method: 'post',
      url: "/api/Restaurants",
      data: {
        RestaurantLink: restaurantlink,
        TempImage: imageUrl,
        RestaurantName:"" ,
        Description:"" ,
        RestaurantName: restaurantName
      },
    }).then(res => { console.log(res) })
  }
}
