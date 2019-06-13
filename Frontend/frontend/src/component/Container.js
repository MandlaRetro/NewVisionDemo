import React, { Component } from 'react'
import HomeScreen from './HomeScreen';
import Contents from './Contents';
import images from '../Pictures/biggerRedCamera.png';

export default class Container extends Component {
    constructor(props) {
        super(props);
        this.state = {
            selectedStory: "",
            stories: [{ "Id": 0, "content":"i did fdiszhbx aisnc iersnvf inerszfb nfsc iawrfnsc ifwncdi fnrescibjnfr eirsnasz frnsc fiwen erihn feridbf eihrbn edfb erv i iev dfi esfdvefsellvfh sv iwe sfd veis viw sz vishd vhea viw  sdxlziv ilwe sdzlih vewh fdsv wiehs dfizhv ig div hrie viv ei didxlvskhf ie sdih vels sd h vd veri vfsih v wef iwesi esd f rec aihf  fhv efdih vihfe svi vs dvhr ewihs tih eig verih vi fdfdi  vfesih ihd id fvih fisd iv hdih iv gfih dvidf hier vki tv this", "Title": "Zuma killed a man", "Author": "Bathande", "image": images },{"Id":1,"content":"tuman","Title":"i did happen","Author":"Tu","image":images}],
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

    render() {
        return (
            <div style={{width:"100%",height:"100%",display:"flex",flexDirection:"column",justifyContent:"center"}}>
                <div><label><b>Top Stories</b></label></div>
            {this.state.page===0?
               <HomeScreen getContent={this.getContent} triggerpages={this.pages}  content={this.state.stories}/> :<Contents triggerpages={this.pages} content={this.state.stories[this.state.index]} />}
            </div>
        )
    }
}
