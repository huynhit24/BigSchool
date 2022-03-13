function postAPI(url,data,success,fail){
	$.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(data),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
			success : success,
			fail : fail
        });
}