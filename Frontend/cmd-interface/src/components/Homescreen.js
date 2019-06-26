import React, { Component } from 'react';
import './home.css';
import Leftoption from './leftcomponent'
import Content from './contentcomponent'
export default class Homescreen extends Component {
    constructor(props){
        super(props);
        this.state ={

        }
    }
    render() {
        return (
            <div className="home-main">
                <Leftoption />
                <Content />
            </div>
        )
    }
}
