import React, { Component } from 'react'
import { RSA_NO_PADDING } from 'constants';

export default class contentcomponent extends Component {
    constructor(props){
        super(props);
        this.state ={
            imageName:"",
            textArticle:"",
            headline:"",
            name:""
        }
    }
    onchange=(e)=>{
        this.setState({
            imageName: URL.createObjectURL(e.target.files[0])
          })
    }
    
    upload=()=>{
        const obj = {
            Author:"bathande tuman data",
            content:this.state.textArticle,
            ImageBase64:this.state.imageName,
            Title:this.state.headline
        }
        // console.log(JSON.stringify(obj))
        fetch("https://localhost:44321/api/cms/postarticle",{
            method:"POST",
            headers:{
                'Content-type': 'application/json'
            },
            body:JSON.stringify(obj)
        })
        .then(res=>res.json())
        .catch(err=>console.log(err))
    }
    
    textonchange=(e)=>{
        this.setState({[e.target.name]:e.target.value})
    }

    render() {
        return (
            <div className="input-content">
                <div className="nav-bar">
                    NEW VISION CONTENT MANANGEMENT SYSTEM 
                </div>
                <div>
                    <label className="first-label">
                        Headline
                    </label>
                    <input typr="text" name="headline" value={this.state.headline} onChange={(e)=>this.textonchange(e)} className="headline-textbox" />

                </div>
                <div className="second">
                    <input type="file" className="input-file" name="myfile" onChange={(e)=>this.onchange(e)}/>
                    <img className="image-box" src={this.state.imageName} />
                </div>
                <div className="third">
                    <label className="third-label">Article</label>
                    <input type="text" className="article-text" name="textArticle" value={this.state.textArticle} onChange={(e)=>this.textonchange(e)} />
                </div>
                <div>
                    <button className="upload-button" onClick={()=>this.upload()}>Upload</button>
                </div>
            </div>
        )
    }
}
