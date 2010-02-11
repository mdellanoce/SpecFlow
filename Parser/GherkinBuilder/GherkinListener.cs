﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Gherkin;
using TechTalk.SpecFlow.Parser.SyntaxElements;

namespace TechTalk.SpecFlow.Parser.GherkinBuilder
{
    internal class GherkinListener : IListener
    {
        public GherkinListener()
        {
            Errors = new List<ErrorDetail>();
        }

        private StepBuilder stepBuilder;
        public List<ErrorDetail> Errors { get; set; }

        public void DisplayRecognitionError(int line, int column, string message)
        {
            string msg = string.Format("({0},{1}): {2}", line, column, message);

            Debug.WriteLine(msg);
            Errors.Add(new ErrorDetail {Message = msg, Row = line, Column = column});
        }

        private FeatureBuilder featureBuilder;
        public Feature GetResult()
        {
            return featureBuilder.GetResult();
        }

        private IList<Tag> tags = new List<Tag>();
        private Tags FlushTags()
        {
            var retval = tags.Any() ? new Tags(tags.ToArray()) : null;
            tags = new List<Tag>();
            return retval;
        }

        private IStepProcessor stepProcessor;
        private ITableProcessor tableProcessor;
        private IExampleProcessor exampleProcessor;

        public void Tag(Token name)
        {
            tags.Add(new Tag(new Word(name.Content)));
        }

        public void Comment(Token content)
        {
        }

        public void Feature(Token keyword, Token name)
        {
            featureBuilder = new FeatureBuilder(name.Content, FlushTags());
        }

        public void Background(Token keyword, Token name)
        {
            var background = new BackgroundBuilder(name.Content, ToFilePosition(keyword.Position));
            stepProcessor = background;
            featureBuilder.AddBackground(background);
        }

        public void Scenario(Token keyword, Token name)
        {
            var currentScenario = new ScenarioBuilder(name.Content, FlushTags(), ToFilePosition(keyword.Position));
            stepProcessor = currentScenario;
            featureBuilder.AddScenario(currentScenario);
        }

        public void ScenarioOutline(Token keyword, Token name)
        {
            var currentScenario = new ScenarioOutlineBuilder(name.Content, FlushTags(), ToFilePosition(keyword.Position));
            stepProcessor = currentScenario;
            exampleProcessor = currentScenario;
            featureBuilder.AddScenario(currentScenario);
        }

        public void Examples(Token keyword, Token name)
        {
            var exampleBuilder = new ExampleBuilder(name.Content, ToFilePosition(keyword.Position));
            tableProcessor = exampleBuilder;
            exampleProcessor.ProcessExample(exampleBuilder);
        }

        public void Step(Token keyword, Token name, StepKind stepKind)
        {
            stepBuilder = new StepBuilder(stepKind, name.Content, ToFilePosition(keyword.Position));
            tableProcessor = stepBuilder;
            stepProcessor.ProcessStep(stepBuilder);
        }

        public void Table(IList<IList<Token>> rows, Position tablePosition)
        {
            tableProcessor.ProcessTable(CreateTable(rows));
        }

        private Table CreateTable(IList<IList<Token>> rows)
        {
            Func<Token, Cell> convertCell = cell => new Cell(new Text(cell.Content)) { FilePosition = ToFilePosition(cell.Position) };
            Func<IList<Token>, Row> convertRow = row => new Row(row.Select(convertCell).ToArray()) { FilePosition = new FilePosition(row[0].Position.Line, row[0].Position.Column - 1) };
            return new Table(convertRow(rows[0]), rows.Skip(1).Select(convertRow).ToArray());
        }

        public void PythonString(Token pyString)
        {
            stepBuilder.SetMultilineArg(pyString.Content);
        }

        public void SyntaxError(string state, string @event, IEnumerable<string> legalEvents, Position position)
        {
            string message = "Parse error. Found " + @event + " when expecting one of: " +
                             string.Join(", ", legalEvents.ToArray()) + ". (Current state: " + state + ").";

            DisplayRecognitionError(position.Line, position.Column, message);
        }

        private FilePosition ToFilePosition(Position position)
        {
            return new FilePosition(position.Line, position.Column);
        }
    }
}