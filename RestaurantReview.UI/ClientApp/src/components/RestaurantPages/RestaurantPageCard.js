import React, { Component } from 'react';
import './Css/RestaurantPageCard.css';

export default class RestaurantPageCard extends Component {

  render() {
    return (
			<div className="resCont align-self-center">
				<div className="row gutters">
					<div className="col-12">
						<div className="card ">
							<div className="card-body">
								<div className="account-settings">
									<div className="user-profile">
										<div className="user-avatar">
											
											<img className="restPic" src="https://eriksberggoteborg.se/wp-content/uploads/2021/04/Piga-bild-1024x774.jpg" alt="Maxwell Admin" />
						</div>
										<a type="variant" href={this.props.website} target="_blank">{this.props.restaurantName}</a>
										<h6 className="user-email"></h6>
										</div>
									<div className="about">
										<h5 className="mb-2 text-primary">About</h5>
										<h3>{this.props.description}</h3>
									</div>
									</div>
								</div>
							</div>
						</div>
					
													</div>
												</div>
      );
  }
  
}