import React, {useState, useContext} from 'react';
import {useHistory, useLocation} from 'react-router-dom';
import {Context as BusContext} from '../../../redux/context/BusContext';

const Other = () => {
    const location = useLocation();
    const history = useHistory();
    const AdhocObj = location.state.AdhocObj;
    const [currentSelected, setCurrentSelected] = useState(6);
    const [description, setDescription] = useState('');
    const {CreateAdhoc} = useContext(BusContext);

    const handleButton = () => {
        AdhocObj.type = parseInt(currentSelected);
        AdhocObj.description = description;

        CreateAdhoc(AdhocObj);
        history.push("driveto", {AdhocObj});
    }

    return (
        <div className="Dropdown-page">
            <select onChange={(e) => setCurrentSelected(e.target.value)}>
                <option value={6}>Anders</option>
            </select>
            <textarea  onChange={(e) => setDescription(e.target.value)} placeholder="Omschrijving..." />
            <button onClick={() => handleButton()}>volgende</button>
        </div>
    )
}

export default Other;