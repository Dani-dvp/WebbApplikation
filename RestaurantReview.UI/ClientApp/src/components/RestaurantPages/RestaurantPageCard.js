import React, { Component } from 'react';
import './Css/RestaurantPageCard.css';

export default class RestaurantPageCard extends Component {

  render() {
    return (
			<div className="resCont align-self-center">
				<div className="row gutters">
					<div className="col-12">
						<div className="card rounded-pill" style={{border: "none", opacity: "95%" }}>
							<div className="card-body rounded-pill" style={{ border: "none", background: "#a73003", opacity: "95%"}}>
								<div className="account-settings">
									<div className="user-profile">
										<div className="user-avatar">
											
											<img className="restPic border border-light" src={ this.props.TempImage } alt="Image not found." />
						</div>
										<a type="variant" href={this.props.website} style={{ color: "#f9e7d9" }} target="_blank"  >{this.props.restaurantName}</a>
										<h6 className="user-email"></h6>
										</div>
									<div className="about">
										<h5 className="mb-2 " style={{ color: "#f9e7d9" }}>About</h5>
										<h3 className="" style={{ color: "#f9e7d9"}}>{this.props.description}</h3>
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