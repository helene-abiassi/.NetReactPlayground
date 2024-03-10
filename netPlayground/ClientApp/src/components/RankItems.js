import React, { useState, useEffect } from 'react';

const RankItems = () => {
    const [items, setItems] = useState([]);


    const dataType = 1;

    function fecthData() {
        fetch(`item/${dataType}`)
            .then((results) => {
                return results.json();
            })
            .then(data => {

                setItems(data);
            })
    }

    useEffect(() => {
        fecthData()
    }, [dataType])


    return (
        <main>
            

            {
                items ? items.map((item) => 
                    <h3>{item.title}</h3>
                ) : <div>Loading...</div>
                }

         


        </main>
)

}

export default RankItems;
