var Bob = function() {};

Bob.prototype.hey = function(statement) {
    statement = statement.trim();
    if(statement == statement.toUpperCase() && statement.match('[a-zA-Z]')){
        return 'Whoa, chill out!';
    }else if(statement.slice(-1) === '?'){
        return 'Sure.';
    }else if (statement === ''){
        return 'Fine. Be that way!';
    }

    return 'Whatever.';
};

module.exports = Bob;
