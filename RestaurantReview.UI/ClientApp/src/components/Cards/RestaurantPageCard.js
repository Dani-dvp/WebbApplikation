import React, { Component } from 'react';
import './CardsCss/RestaurantPageCard.css';

export default class RestaurantPageCard extends Component {

  render() {
    return (
			<div className="resCont align-self-center">
				<div className="row gutters">
					<div className="col-12">
						<div className="card h-100">
							<div className="card-body">
								<div className="account-settings">
									<div className="user-profile">
										<h1 className="user-name">{this.props.restaurantName}</h1>
										<div className="user-avatar">
											
											<img className="restPic" src="https://eriksberggoteborg.se/wp-content/uploads/2021/04/Piga-bild-1024x774.jpg" alt="Maxwell Admin" />
						</div>
										
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