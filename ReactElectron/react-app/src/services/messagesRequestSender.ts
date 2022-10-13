import { IMessage } from "../models/IMessage";

const apiEndpoint = 'https://localhost:7200/messages';

export const createMessage = (message: IMessage) => {
    fetch(apiEndpoint, { 
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({ ...message })
    });
}

export const removeAllMessages = () => {
    fetch(apiEndpoint, { method: "DELETE" });
}

export const getAllMessagesAsync = (): Promise<IMessage[]> => {
    return fetch(apiEndpoint)
    .then(async response => {
        const json = await response.json();

        return json.messages as IMessage[];
    })
}