import React, { Component } from 'react'
import HomeScreen from './HomeScreen';
import Contents from './Contents';
import images from '../Pictures/biggerRedCamera.png';

export default class Container extends Component {
    constructor(props) {
        super(props);
        this.state = {
            selectedStory: "",
            stories:[],
            page:0,
            index:""
        }
        this.pages=this.pages.bind(this);
    }

    pages(id){
        this.setState({page:id})
    }

    getContent=(index)=>{
        this.setState({index:index})
    }

    componentWillMount(){
        fetch("https://localhost:44321/api/cms")
        .then(res=>res.json())
        .then(data=>{
            this.setState({stories:data})
            console.log("here",data)
        })
    }

    render() {
        return (
            <div style={{width:"100%",height:"100%",display:"flex",flexDirection:"column",justifyContent:"center"}}>
                <div style={{height:"50px",background:"#ed1c24",display:"flex",flexDirection:"column",justifyContent:"center"}}><label style={{color:"white"}}><b>NEW VISION</b></label></div>
            {this.state.page===0?
               <HomeScreen getContent={this.getContent} triggerpages={this.pages}  content={this.state.stories}/> :<Contents triggerpages={this.pages} content={this.state.stories[this.state.index]} />}
            </div>
        )
    }
}
