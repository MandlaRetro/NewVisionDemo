import React, { Component } from 'react'
import HomeScreen from './HomeScreen';
import Contents from './Contents';

export default class Container extends Component {
    constructor(props) {
        super(props);
        this.state = {
            selectedStory: "",
            stories: [{ "Id": 1, "content":"i did fdiszhbx aisnc iersnvf inerszfb nfsc iawrfnsc ifwncdi fnrescibjnfr eirsnasz frnsc fiwen erihn feridbf eihrbn edfb erv i iev dfi esfdvefsellvfh sv iwe sfd veis viw sz vishd vhea viw sdxlziv ilwe sdzlih vewh fdsv wiehs dfizhv ig div hrie viv ei didxlvskhf ie sdih vels sd h vd veri vfsih v wef iwesi esd f rec aihf  fhv efdih vihfe svi vs dvhr ewihs tih eig verih vi fdfdi  vfesih ihd id fvih fisd iv hdih iv gfih dvidf hier vki tv this", "Title": "Zuma killed a man", "Author": "Bathande", "image": null }],
            page:0
        }
        this.pages=this.pages.bind(this);
    }

    pages(id){
        this.setState({page:id})
    }

    render() {
        return (
            <div style={{width:"100%",height:"100%",display:"flex",justifyContent:"center"}}>
            {this.state.page===0?
               <HomeScreen triggerpages={this.pages} /> :<Contents triggerpages={this.pages} content={this.state.stories[0]} />}
            </div>
        )
    }
}
