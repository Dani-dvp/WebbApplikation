import React from 'react'
import axios from 'axios';


/*Denna klassen används inte, ville inte ta bort ännu innan vi vet om det behövs en separat fileupload eller inte*/
class FileUpload extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      selectedFile: '',
      user: this.props.user
    }

    this.handleInputChange = this.handleInputChange.bind(this);
  }

  handleInputChange(event) {
    this.setState({
      selectedFile: event.target.files[0],
    })
  }

  submit() {
    const data = new FormData()
    data.append('file', this.state.selectedFile)
    console.warn(this.state.selectedFile);
    console.log(this.state.user.data)
    

    axios.post("api/image", data, {
       // receive two parameter endpoint url ,form data 
    })
      

  }

  render() {
    return (
      <div>
        <div className="row">
          <div className="col-md-6 offset-md-3">
            <br /><br />

            <h3 className="text-white">React File Upload - Nicesnippets.com</h3>
            <br />
            <div className="form-row">
              <div className="form-group col-md-6">
                <label className="text-white">Select File :</label>
                <input type="file" className="form-control" name="upload_file" onChange={this.handleInputChange} />
              </div>
            </div>

            <div className="form-row">
              <div className="col-md-6">
                <button type="submit" className="btn btn-dark" onClick={() => this.submit()}>Save</button>
              </div>
            </div>
          </div>
        </div>
      </div>
    )
  }
}

export default FileUpload;