import React, { Component } from 'react'
import "../css/HomeS.css"

export class HomeScreen extends Component {
    constructor(props) {
        super(props);
        this.state = {
            selectedStory: "",
            stories: [{ "Id": 1, "Content": "i did this", "Title": "Zuma killed a man", "Author": "Bathande", "image": null }],
        }
    }

    cont=(index)=>{
        this.props.triggerpages(1);
        this.props.getContent(index);
    }

    render() {
        var { triggerpages , ...otherProps} = this.props;
        const items = (
            <div className="items-main">
                <table className="item-container" style={{width:"100%"}}>
                    <tbody>
                        {this.props.content.map((story,index) => (
                            <tr className="item-row" key={story.Id} style={{width:"100%"}}>
                                <td style={{width:"100%"}} className="item-col">
                                    <button onClick={()=>this.cont(index)} type="button" style={{width:"100%",textAlign:"left",height:"60px",display:"flex",justifyContent:"space-between"}} class="btn btn-default">{story.title} <div style={{width:"40px",height:"40px"}}><img style={{width:"45px",height:"45px"}} src={story.imageBase64} /></div></button>
                                </td>
                               
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
        )
        return (
            <div className="home-screen-main" style={{width:"100%"}}>
                {items}
            </div>
        )
    }
}

const mapStateToProps = (state) => ({

})
export default (HomeScreen)
