import React, { Component } from 'react'

export default class Contents extends Component {
    constructor(props){
        super(props);

    }

    render() {
        return (
            <div style={{display:"flex",flexDirection:"column"}}>
               <div style={{width:"10%",borderRadius:"5%"}}> <button onClick={()=>this.props.triggerpages(0)}></button> </div>
               <div style={{width:"100%",display:"flex",flexWrap:"wrap"}}>{this.props.content}</div>           
            </div>
        )
    }
}
