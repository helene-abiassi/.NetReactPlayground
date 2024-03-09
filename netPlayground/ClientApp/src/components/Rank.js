import React, { useState, useEffect, Component } from 'reatc';


export class Rank extends Component  {
    const [items, setItems] = useState([])

    const itemType = 1;

    const fetchedData = () => {
        fetch(`item/${itemType}`).then((results) => {
            return results.json();
        }).then(data => {
            setItems(data)
        })
    }

    useEffect(() => {
        fetchedData()
    }, [])

    return (
        <>
            //{items && items.map }

        </>
    )
}