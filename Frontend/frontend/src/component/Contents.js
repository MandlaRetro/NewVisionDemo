import React, { Component } from 'react'

export default class Contents extends Component {
    constructor(props){
        super(props);

    }

    back =()=>{
        this.props.triggerpages(0);
    }

    render() {
        return (
            <div style={{display:"flex",flexDirection:"column",width:"98%"}}>
               <div style={{width:"50px",borderRadius:"5%"}}> <button style={{width:"50px",borderRadius:"5%",height:"50px"}} onClick={this.back}><b>BACK</b></button> </div>
               <div><label style={{fontSize:"14px",color:"black"}}><b>{this.props.content.Title}</b></label></div><br/>
               <div style={{textAlign:"left"}}><label><b>Author {this.props.content.Author}</b></label></div>
               <div style={{width:"100%",display:"flex",flexWrap:"wrap",textAlign:"left",paddingLeft:"1%"}}>{this.props.content.content}</div>           
            </div>
        )
    }
}
